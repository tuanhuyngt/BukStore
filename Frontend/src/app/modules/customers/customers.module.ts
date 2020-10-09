import { CustomerAddComponent } from './customer-add/customer-add.component';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModulesRoutingModule } from '../modules-routing.module';
import { FormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';
import {  CalendarModule, CheckboxModule, PaginatorModule } from 'primeng/primeng';
import { CustomerManagementComponent } from './customer-management/customer-management.component';
import { CustomersServiceProxyModule } from './customers.service-proxy.module';
import { UtilsModule } from '@shared/utils/utils.module';



@NgModule({
  imports: [
    CommonModule,
    ModulesRoutingModule,   
    FormsModule,
    TableModule,
    CalendarModule,
    CheckboxModule,
    CustomersServiceProxyModule,
    CalendarModule,      
    PaginatorModule,
    UtilsModule
  ],
  declarations: [CustomerManagementComponent, CustomerAddComponent]
})
export class CustomersModule { }
