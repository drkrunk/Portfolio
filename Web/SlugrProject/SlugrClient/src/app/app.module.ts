import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'
import {HttpClientModule, HttpInterceptor, HTTP_INTERCEPTORS} from '@angular/common/http'
import { NgbModal, NgbModule  } from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import {AuthService} from './auth.service'
import { AuthGuard } from './auth.guard';
import { TokenInterceptorService } from './token-interceptor.service';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProjectComponent } from './project/project.component';
import { TicketComponent } from './ticket/ticket.component';
import { NewprojectComponent } from './newproject/newproject.component';
import { ProjectSettingsComponent } from './project-settings/project-settings.component';
import { JoinProjectComponent } from './join-project/join-project.component';
import { NewTicketComponent } from './new-ticket/new-ticket.component';
import { ProjectListComponent } from './project-list/project-list.component';
import { ProfileComponent } from './profile/profile.component';
import { DateAgoPipe } from './utils/date-ago.pipe';
import { PublicProjectComponent } from './public-project/public-project.component';
import { PinListComponent } from './pin-list/pin-list.component';
import { ImageCropperComponent } from './image-cropper/image-cropper.component';
import {
  AngularFireStorageModule,
  AngularFireStorageReference,
  AngularFireUploadTask,
  StorageBucket
} from "@angular/fire/storage";
import { AngularFireModule } from 'angularfire2';
import { TagInputModule } from 'ngx-chips';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';
import {DragDropModule} from '@angular/cdk/drag-drop';


import { environment } from "../environments/environment";


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    DashboardComponent,
    ProjectComponent,
    TicketComponent,
    NewprojectComponent,
    ProjectSettingsComponent,
    JoinProjectComponent,
    NewTicketComponent,
    ProjectListComponent,
    ProfileComponent,
    DateAgoPipe,
    PublicProjectComponent,
    PinListComponent,
    ImageCropperComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    NgbModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebaseConfig, "cloud"),
    AngularFireStorageModule,
    TagInputModule,
    BrowserAnimationsModule, 
    ReactiveFormsModule,
    DragDropModule
  ],
  providers: [AuthService, AuthGuard,

  {
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptorService,
    multi: true
  }],

  bootstrap: [AppComponent]
})
export class AppModule { }
