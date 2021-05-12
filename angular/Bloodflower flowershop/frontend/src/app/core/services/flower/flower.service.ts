import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { FlowerRequest } from 'src/app/modules/admin/request/flower.request';
import { FlowerModel } from 'src/app/shared/models/flower.model';
import { environment } from 'src/environments/environment';

@Injectable({
	providedIn: 'root',
})
export class FlowerService {
	private endpoint = 'flower';

	constructor(private readonly http: HttpClient) {}

	public getAllFlowers(): Observable<FlowerModel[]> {
		return this.http.get<FlowerModel[]>(
			`${environment.apiUrl}/${this.endpoint}`
		);
	}

	public getFlowers(limit?: number): Observable<FlowerModel[]> {
		return this.http.get<FlowerModel[]>(
			`${environment.apiUrl}/${this.endpoint}`,
			{
				params: {
					limit: `${limit}`,
				},
			}
		);
	}

	public getFlower(id: number): Observable<FlowerModel> {
		return this.http.get<FlowerModel>(
			`${environment.apiUrl}/${this.endpoint}/${id}`
		);
	}

	public searchFlower(name: string): Observable<FlowerModel[]> {
		return this.http.get<FlowerModel[]>(
			`${environment.apiUrl}/${this.endpoint}/search`,
			{
				params: {
					name: name,
				},
			}
		);
	}

	public createFlower(flowerRequest: FlowerRequest): Observable<FlowerModel> {
		return this.http.post<FlowerModel>(
			`${environment.apiUrl}/${this.endpoint}`,
			flowerRequest
		);
	}

	public updateFlower(
		id: number,
		flowerRequest: FlowerRequest
	): Observable<FlowerModel> {
		return this.http.patch<FlowerModel>(
			`${environment.apiUrl}/${this.endpoint}/${id}`,
			flowerRequest
		);
	}

	public deleteFlower(id: number): Observable<FlowerModel> {
		return this.http.delete<FlowerModel>(
			`${environment.apiUrl}/${this.endpoint}/${id}`
		);
	}
}
