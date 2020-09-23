
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModulesRoutingModule } from '../modules-routing.module';
import { FormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';
import {  CalendarModule, CheckboxModule, PaginatorModule } from 'primeng/primeng';
import { AuthorManagementComponent } from './author-management/author-management.component';
import { AuthorsServiceProxyModule } from './authors.service-proxy.module';
import { UtilsModule } from '@shared/utils/utils.module';



@NgModule({
  imports: [
    CommonModule,
    ModulesRoutingModule,   
    FormsModule,
    TableModule,
    CalendarModule,
    CheckboxModule,
    AuthorsServiceProxyModule,
    CalendarModule,      
    PaginatorModule,
    UtilsModule
  ],
  declarations: [AuthorManagementComponent]
})
export class AuthorsModule { }
