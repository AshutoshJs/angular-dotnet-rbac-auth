import { HttpClient, HttpParams } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import {FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
loginForm : FormGroup;
private http = inject(HttpClient);

constructor(private fb:FormBuilder,private router: Router) {
    this.loginForm =  this.fb.group({
      password: ['',Validators.required],
      email: ['',Validators.required]
      }
    )
}
onSubmit(){
  var email = this.loginForm.get('email')?.value;
  var pasword = this.loginForm.get('password')?.value;
  var param = {
"Email": email,
  "Password":pasword

  }
   const body=JSON.stringify(param);
const params = new HttpParams({
  
})
  this.http.post<any>('https://localhost:7119/api/Login',param).subscribe(
    response=>{
      
      var temp=  response;
      
      localStorage.setItem('myToken', temp?.token);
this.router.navigate(['/employees']);
    }
  )
}

//EOC
}
