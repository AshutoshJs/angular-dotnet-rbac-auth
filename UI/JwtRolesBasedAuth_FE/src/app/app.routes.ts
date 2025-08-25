import { Routes } from '@angular/router';
import { EmployeesComponent } from './views/employees/employees.component';
import { VehiclesListComponent } from './views/vehicles-list/vehicles-list.component';
import { LoginComponent } from './views/login/login.component';
import { routeGuard } from './guard/route.guard';

export const routes: Routes = [
     { path: '', redirectTo: 'login', pathMatch: 'full' }, 
     { path: 'login', component: LoginComponent },   
      { path: 'employees', component: EmployeesComponent,canActivate:[routeGuard] },   
      { path: 'vehicles', component: VehiclesListComponent }, 
];
