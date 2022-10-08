import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpRequest } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  register(newUser){
    delete newUser.confirmPassword;
    console.log(newUser)
    //* Not connect to a DB at the moment */
    this.authenticate("I'm registered")
    // this.http.post("any_string", newUser).subscribe(res =>{
    //   this.authenticate(res)
    // })
  }
  // Todo: Have this communicate to the backend for JWT authentication
  authenticate(res){
    console.log(res)
  }
}
