import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router, NavigationEnd } from '@angular/router';
import { Project } from '../models/project';
import { ProjectService } from '../project.service';


@Component({
  selector: 'app-project-settings',
  templateUrl: './project-settings.component.html',
  styleUrls: ['./project-settings.component.scss']
})

export class ProjectSettingsComponent implements OnInit, OnDestroy {

  private _url: String = "/join?join_id=";

  currentProject:Project;
  projectid;
  encoded;
  navigationSubscription;

  constructor(private _projectService: ProjectService, private route: ActivatedRoute, private router: Router) {

    this.route.queryParams.subscribe(
      data => {this.projectid = atob(data.edit_id)}
      );
    
    this.navigationSubscription = this.router.events.subscribe((e: any) => {
      if (e instanceof NavigationEnd) this.initialiseInvites();
    });

  }
  ngOnDestroy(): void {
    if (this.navigationSubscription)
      this.navigationSubscription.unsubscribe();
  }

  ngOnInit() {
    this.initialiseInvites();
  }

  initialiseInvites() {
    this._projectService.getProjectById(this.projectid).subscribe(
      res => {
        this.currentProject = res;
        this._encodeJoinString();
        console.log(res);
      },
      err => { console.log(err); }
    )
  }

  onProjectNameChanged(value) {
    this.currentProject.projectName = value;
    this.saveProject();
  }

  onDescriptionChanged(value) {
    this.currentProject.projectDescription = value;
    this.saveProject();
  }

  testClick() {
    console.log("TEST");
  }

  onChangedPublic() {
    this.currentProject.publicProject = !this.currentProject.publicProject;
    console.log(this.currentProject.publicProject);
    this.saveProject();
  } 
 
  saveProject() {
    this._projectService.saveProject(this.currentProject).subscribe(
      res => { console.log(res),this._encodeJoinString() },
      err => { console.log(err) }
    )
  }

  onDelete(){
    this._projectService.deleteProject(this.currentProject).subscribe(
      res => { this.router.navigate(['dashboard']) },
      err => { console.log(err) }
    )

  }

  copyInputMessage(inputElement) {
  
    this._encodeJoinString();
    inputElement.select();
    document.execCommand('copy');
    inputElement.setSelectionRange(0, 0);
    inputElement.blur();
  }

  private _encodeJoinString(){
    let params = {id: this.currentProject.id, ownerId: this.currentProject.ownerId};
    console.log(JSON.stringify(params))
    this.encoded =  this._url +  btoa(JSON.stringify(params));
  }
}
