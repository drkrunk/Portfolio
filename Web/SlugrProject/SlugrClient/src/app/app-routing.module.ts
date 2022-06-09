import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AuthGuard } from './auth.guard';
import { NewprojectComponent } from './newproject/newproject.component';
import { ProjectComponent } from './project/project.component';
import { ProjectSettingsComponent } from './project-settings/project-settings.component';
import { NewTicketComponent } from './new-ticket/new-ticket.component';
import { TicketComponent } from './ticket/ticket.component';
import { JoinProjectComponent } from './join-project/join-project.component';
import { ProfileComponent } from './profile/profile.component';
import { PublicProjectComponent } from './public-project/public-project.component';


const routes: Routes = [
  {
    path:'',
    redirectTo:'/login',
    pathMatch:'full'
  },
  {
    path:'login',
    component: LoginComponent
  },
  {
    path:'register',
    component: RegisterComponent
  },
  {
    path:'join',
    component: JoinProjectComponent,
    pathMatch:'full',
    canActivate: [AuthGuard]
  },
  {
    path:'user/:id/profile', 
    component: ProfileComponent
  },
  
  {
    path:'dashboard',
    component: DashboardComponent,
    children:[
      {path:'new_project', component: NewprojectComponent},
      {path:'project/:id', component:ProjectComponent},
      {path:'project/**', component: DashboardComponent},
      {path:'project_settings/:id', component: ProjectSettingsComponent},
      {path:'ticket/:id', component: TicketComponent},
      {path:'public_projects', component: PublicProjectComponent}
      
      
      
    ],
    canActivate: [AuthGuard],
    runGuardsAndResolvers: 'always'
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes, {onSameUrlNavigation: 'reload'})],
  exports: [RouterModule]
})

export class AppRoutingModule { }

export const routingComponents = 
[LoginComponent, 
  RegisterComponent,
  DashboardComponent,
  NewprojectComponent,
  ProjectComponent,
  ProjectSettingsComponent,
  TicketComponent,
  ProfileComponent,
  PublicProjectComponent
];
