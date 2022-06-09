import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Project } from './models/project';


@Injectable({
  providedIn: 'root'
})
export class ProjectService {
  private _url = "http://localhost:9000/api/projects";

  constructor(private http: HttpClient ) { }

  getAllProjects(){
    return this.http.get<any>(this._url+"/all");
  }
  createProject(project){
    return this.http.post<any>(this._url+"/create",project)
  }

  saveProject(project){
    return this.http.post<any>(this._url+"/save",project)
  }

  getProjectById(pid){
    return this.http.get<any>(this._url+"/"+pid);
  }

  getProjectByLoggedInUser(){
    return this.http.get<any>(this._url+"/my");
  }

  deleteProject(project){
    return this.http.post<any>(this._url+"/delete",project)

  }

  joinProject(project){
    return this.http.post<any>(this._url+"/members/join",project)
  }

  getJoinedProjects(){
    return this.http.get<any>(this._url+"/team-projects");
  }

  leaveProject(project:Project){
    return this.http.post<any>(this._url+"/leave-project",project);
  }
}
