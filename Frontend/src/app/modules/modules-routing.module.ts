import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { AuthorManagementComponent } from "./authors/author-management/author-management.component";





@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: "",
                children: [                                                                 
                    {
                        path: 'author-management', component: AuthorManagementComponent
                    }
                ],
            },
        ]),
    ],
    exports: [RouterModule]
})
export class ModulesRoutingModule { }
