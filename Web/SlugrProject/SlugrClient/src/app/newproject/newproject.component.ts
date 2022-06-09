import { Component, OnInit } from '@angular/core';
import {  Router, ActivatedRoute } from '@angular/router';
import { ProjectService } from '../project.service';

@Component({ 
  selector: 'app-newproject',
  templateUrl: './newproject.component.html',
  styleUrls: ['./newproject.component.scss']
})
export class NewprojectComponent implements OnInit {

  newProjectData = {};

  constructor(private _projectService: ProjectService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
  }

  createProject(){
    console.log(this.newProjectData);
    this._projectService.createProject(this.newProjectData).subscribe(
      res=>{
        //this.router.navigate(['/dashboard/project_settings/',  btoa(res)], {queryParams: {edit_id:btoa(res.id)}} ) ;
        this.router.navigate(['/dashboard/']);
      },
      err =>{console.log(err)}

    );
    
  }

}
