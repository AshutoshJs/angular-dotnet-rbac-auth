import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';

export const routeGuard: CanActivateFn = (route, state) => {
 var router = inject(Router)
  console.log("inside routeGuard && route",route," state",state)
 const token = localStorage.getItem('myToken');
  if(token)
  return true;
else{
 router.navigate(['/Login'])
  return false;
}
  
};
