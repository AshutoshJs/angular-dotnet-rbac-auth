import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { TableModule } from 'primeng/table';
@Component({
  selector: 'app-employees',
  imports: [TableModule],
  templateUrl: './employees.component.html',
  styleUrl: './employees.component.scss'
})
export class EmployeesComponent implements OnInit {
private http = inject(HttpClient);
  ngOnInit(): void {
      
  
   //const body=JSON.stringify(param);

  this.http .get<any>('https://localhost:7119/WeatherForecast').subscribe(
    response=>{
      
     //console.log("response",response);  
      
     
    }
  )
  }
}
