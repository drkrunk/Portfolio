import {Account} from './account';
import {Comment} from './comment';
import { Project } from './project';
import { Tag } from './tag';

export class Ticket{
    id: bigint;
    account:Account;
    project:Project;
    comments:Array<Comment>;

    dateFixed: Date;
    dateSubmitted: Date;
    description: string;
    esculated: boolean;
    expirationDate: Date;
    fixed: boolean;
    suspended:boolean;
    title:string;
    workerId:bigint;

    tags:Array<Tag>;


}