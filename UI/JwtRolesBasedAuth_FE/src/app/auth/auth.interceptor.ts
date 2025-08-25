import { HttpInterceptorFn } from '@angular/common/http';

export const authInterceptor: HttpInterceptorFn = (req, next) => {

 const token = localStorage.getItem('myToken');
 //console.log("token",token)
 req= req.clone({headers : req.headers.set('Authorization', `Bearer ${token}`)});
//req= req.clone({headers : req.headers.set( Authorization: `Bearer ${token}` )});
//console.log("req",req)
  return next(req);
};
