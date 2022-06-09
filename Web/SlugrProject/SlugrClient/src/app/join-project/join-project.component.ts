import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Project } from '../models/project';
import { ProjectService } from '../project.service';

@Component({
  selector: 'app-join-project',
  templateUrl: './join-project.component.html',
  styleUrls: ['./join-project.component.css']
})
export class JoinProjectComponent implements OnInit {
  project = {};
  constructor(private route: ActivatedRoute, private _projectService: ProjectService, private _router: Router) {
    this.route.queryParams.subscribe(
      data => {
        let param:Project = JSON.parse(atob(data.join_id))

        this._projectService.getProjectById(param.id).subscribe(
          res=>{this.project = res},
          err=>{console.log(err)}

        )

      },
      err => {
        console.log(err)
      }
    );
    console.log(this.project);
  }

  ngOnInit(): void {


  }
  cancelJoin() { 
    this._router.navigate(['dashboard/public_projects'])

  }

  joinProject() {
    if (this.project != null) {
      console.log(this.project);
      this._projectService.joinProject(this.project).subscribe(
        res => { this._router.navigate(['dashboard/public_projects']) },
        err => { console.log(err) }
      )

    }

  }

}
