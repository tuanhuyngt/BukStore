import { Component, Injector, ViewChild, ViewEncapsulation } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import { CustomerSearchDto, CustomerServiceProxy } from '@shared/service-proxies/service-proxies';
import { LazyLoadEvent } from 'primeng/components/common/lazyloadevent';
import { Paginator } from 'primeng/components/paginator/paginator';
import { Table } from 'primeng/components/table/table';


@Component({
    templateUrl: './customer-add.component.html',
    encapsulation: ViewEncapsulation.None,
    animations: [appModuleAnimation()]
})
export class CustomerAddComponent extends AppComponentBase {

    @ViewChild('dataTable') dataTable: Table;
    @ViewChild('paginator') paginator: Paginator;

    //Filters
    advancedFiltersAreShown = false;
    filterText = '';

    constructor(
        injector: Injector,
        private _activatedRoute: ActivatedRoute,
        private _CustomerServiceProxy: CustomerServiceProxy
    ) {
        super(injector);
        this.filterText = this._activatedRoute.snapshot.queryParams['filterText'] || '';
    }

    customerSearchDto : CustomerSearchDto = new CustomerSearchDto();

    getUsers(event?: LazyLoadEvent) {
        if (this.primengTableHelper.shouldResetPaging(event)) {
            this.paginator.changePage(0);
            return;
        }

        this.customerSearchDto.customer_Name = this.filterText;
        this.primengTableHelper.showLoadingIndicator();

        this._CustomerServiceProxy.cUSTOMER_Search(this.customerSearchDto).subscribe(
            result => {
                this.primengTableHelper.records = result;
                this.primengTableHelper.hideLoadingIndicator();
                console.log(result);
            }
        )
       
    }
 
    reloadPage(): void {
        this.paginator.changePage(this.paginator.getPage());
    }

    exportToExcel(): void {
        
    }

    createUser(): void {
        
    }

    deleteUser(): void {
             
    }
}
