import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from 'src/app/shared/models/user.model';
import { environment } from 'src/environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
	private readonly STORAGE_KEY = 'currentFlowerUser';
	private currentUserSubject: BehaviorSubject<User>;
	public currentUser: Observable<User>;

	constructor(private http: HttpClient) {
		this.currentUserSubject = new BehaviorSubject<User>(
			JSON.parse(localStorage.getItem(this.STORAGE_KEY))
		);
		this.currentUser = this.currentUserSubject.asObservable();
	}

	public get currentUserValue(): User {
		return this.currentUserSubject.value;
	}

	public login(username: string, password: string): Observable<User> {
		return this.http
			.post<User>(`${environment.apiUrl}/auth/login`, {
				username,
				password,
			})
			.pipe(
				map((user: User) => {
					localStorage.setItem(
						this.STORAGE_KEY,
						JSON.stringify(user)
					);
					this.currentUserSubject.next(user);
					return user;
				})
			);
	}

	logout(): void {
		localStorage.removeItem(this.STORAGE_KEY);
		this.currentUserSubject.next(null);
	}
}
