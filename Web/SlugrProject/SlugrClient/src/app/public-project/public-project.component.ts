import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Project } from '../models/project';
import { ProjectService } from '../project.service';

@Component({
  selector: 'app-public-project',
  templateUrl: './public-project.component.html',
  styleUrls: ['./public-project.component.css']
})
export class PublicProjectComponent implements OnInit {

  projects = []

  constructor(private _projectService:ProjectService, private _router:Router) { }

  ngOnInit(): void {
    this._projectService.getAllProjects().subscribe(
      res=> this.projects = res,
      err => console.log(err)

    )
  }

  onJoinProject(currentProject:Project ){
    let params = {id: currentProject.id, ownerId: currentProject.ownerId};
    console.log(JSON.stringify(params))
    let encoded =  btoa(JSON.stringify(params));

    this._router.navigate(['/join'], {queryParams:{ join_id: encoded }})

  }

}
