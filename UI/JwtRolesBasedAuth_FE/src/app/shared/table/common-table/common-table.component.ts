import { Component, Input, ViewChild } from '@angular/core';
import { PrimeComponentModule } from '../../prime-component/prime-component.module';
import { CommonModule } from '@angular/common';
import { PipesModule } from '../../pipes/pipes.module';
import { Column } from '../columns/columns.interface';

@Component({
  standalone: true,
  selector: 'app-common-table',
  imports: [
    PrimeComponentModule,
  ],
  templateUrl: './common-table.component.html',
  styleUrl: './common-table.component.scss'
})
export class CommonTableComponent {

  //  @Input() columns!: Array<Column>;
   @Input() columns!: Array<any>;
@Input() data!: any;

 @Input() rowsLimit: number = 5;


  isPaginator: boolean = true;


}
