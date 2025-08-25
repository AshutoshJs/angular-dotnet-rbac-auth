import { Component } from '@angular/core';
import { PrimeComponentModule } from '../../shared/prime-component/prime-component.module';
import { TempData } from '../../common/TempData';
import { CommonTableComponent } from '../../shared/table/common-table/common-table.component';
@Component({
  selector: 'app-vehicles-list',
  imports: [
    PrimeComponentModule,
    CommonTableComponent
  ],
  templateUrl: './vehicles-list.component.html',
  styleUrl: './vehicles-list.component.scss'
})
export class VehiclesListComponent {
  vehicles = TempData.vehicles;
  /*static vehicles=[
   {
     "id": 1,
     "make": "Toyota",
     "year": 2020
   },
   {
     "id": 2,
     "make": "Honda",
     "year": 2021
   }
 ]*/
  columns = [
    {
      'header': 'ID',
      'name': 'id',
      'sorting': true
    }, {
      'header': 'MAKE',
      'name': 'make',
      'sorting':true
    }, {
      'header': 'YEAR',
      'name': 'year',
      'sorting':false
    }
  ]
}
