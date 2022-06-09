import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ActivatedRoute, Router} from '@angular/router';
import { ProjectService } from '../project.service';


@Component({
  selector: 'app-dashboard ',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})

export class DashboardComponent implements OnInit {
  newProjectData = {};
 
  constructor(private _projectService: ProjectService, private modalService: NgbModal, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {}


  createProject(){
    
    this._projectService.createProject(this.newProjectData).subscribe(
      res=>{
        this.router.navigate(['project', res.id], { relativeTo: this.route, queryParams: { id: res.id, projectName: res.projectName, description: res.description } });
      },
      err =>{console.log(err)}

    );
  }

}
