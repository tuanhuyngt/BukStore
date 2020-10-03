import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { AuthorManagementComponent } from "./authors/author-management/author-management.component";
import { CustomerManagementComponent } from "./customers/customer-management/customer-management.component";





@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: "",
                children: [                                                                 
                    {
                        path: 'author-management', component: AuthorManagementComponent
                    },
                    {
                        path: 'customer-management', component: CustomerManagementComponent
                    }
                ],
            },
        ]),
    ],
    exports: [RouterModule]
})
export class ModulesRoutingModule { }
