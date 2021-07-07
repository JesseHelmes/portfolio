import { Request } from 'express';
import { IUserAuthenticated } from './user-authenticated.interface';

export interface AuthRequest extends Request {
	user: IUserAuthenticated;
}
