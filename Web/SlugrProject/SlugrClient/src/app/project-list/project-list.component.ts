import { Component, OnInit } from '@angular/core';
import { ProjectService } from '../project.service';
import { Router, ActivatedRoute, NavigationEnd } from '@angular/router';
import { Project } from '../models/project';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  private dashData:Array<Project> = []
  private teamProjects:Array<Project> = []
  private hasProjects:boolean = false;
  private navigationSubscription:any;

  constructor(private _projectService: ProjectService, private route: ActivatedRoute, private router: Router) { 

    this.navigationSubscription = this.router.events.subscribe((e: any) => {if (e instanceof NavigationEnd) this.initialiseProjectList();});
  }

  ngOnInit(): void {}

 

  ngOnDestroy(): void {

    if(this.navigationSubscription)
      this.navigationSubscription.unsubscribe();
  }

  initialiseProjectList() {
    this._projectService.getProjectByLoggedInUser().subscribe( res => this.onGetAccountsProjects(res),err => console.log(err));
    this._projectService.getJoinedProjects().subscribe( res => this.onGetTeamProjects(res),err => console.log(err));

  }

  onGetAccountsProjects(res:Array<Project>){
    this.dashData = res;
    this.hasProjects = (this.dashData.length>0);
  }

  onGetTeamProjects(res:Array<Project>){
    this.teamProjects = res;
    this.hasProjects = (this.dashData.length>0);
  }

  onNewProject() {
    this.router.navigate(['new_project'], { relativeTo: this.route });
  }

  onGoToProject(project) {
    this.router.navigate(['project', project.id], { relativeTo: this.route, queryParams: { id: project.id, projectName: project.projectName, description: project.description } }); 
  }

  onGoToProjectSettings(project) {
    this.router.navigate(['project_settings', project.projectName], { relativeTo: this.route, queryParams: { edit_id: btoa(project.id)} });
  }

  onMemberClick(member){
    console.log(member);
  }

}
