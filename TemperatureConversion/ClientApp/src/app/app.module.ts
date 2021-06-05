import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material/material.module';
import { TempConversionService } from './temp-conversion.service';
import { GenericService } from './services/generic.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,    
    ReactiveFormsModule,
    
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },      
    ]),
    BrowserAnimationsModule,
    MaterialModule,

  ],
  providers: [GenericService,
    TempConversionService],
  bootstrap: [AppComponent]
})
export class AppModule {
  //static forRoot(): ModuleWithProviders {
  //  return {
      
  //    providers: [
  //      GenericService,
  //      TournamentService
  //    ]
  //  }
  //}
}
