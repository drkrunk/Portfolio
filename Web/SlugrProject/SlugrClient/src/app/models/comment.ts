import {Account} from './account'

export class Comment{

    account:Account;
    id:bigint;
    postedOn:Date;
    text:string;
    rowVersion:number;
}