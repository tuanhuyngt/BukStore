
import { NgModule } from "@angular/core";

import {
    MenuClientServiceProxy,
    DemoModelServiceProxy,
} from "@shared/service-proxies/service-proxies";

import { TableModule } from "primeng/table";
import { FormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { CommonModule } from "@angular/common";
import { CalendarModule } from "primeng/components/calendar/calendar";
import { CheckboxModule } from 'primeng/checkbox';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ConfirmationService } from 'primeng/api';
import { ModulesRoutingModule } from "./modules-routing.module";
import { ModulesServiceProxyModule } from "./modules.service-proxy.module";
import { RouterModule } from "@angular/router";
import { AuthorsModule } from './authors/authors.module';


@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        TableModule,
        CalendarModule,
        CheckboxModule,
        ConfirmDialogModule,
        ModulesRoutingModule,
        ModulesServiceProxyModule,
        RouterModule,
        AuthorsModule,       
    ],
    declarations: [
    ],
    providers: [ConfirmationService]
})
export class ModulesModule { }
