import { Component, OnInit } from '@angular/core';
import { IUser } from '../../interfaces/user';
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { AuthService } from 'src/app/services/authentication/auth.service';
// import { FormGroupTypeSafe } from ''

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  // Todo: Figure out why IUser interface not working here
  // registerUser: IFormGroup<IUser>;
  newUser: IUser;
  registerUser;

  constructor(private form: FormBuilder, private auth: AuthService) {
    this.registerUser = this.form.group({
      firstName: ['', Validators.required],
      middleName: [''],
      lastName: ['', Validators.required],
      email: ['', [Validators.email, emailValid()]],
      phoneNumber: [''],
      gender: [''],
      age: [''],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required]
    }, { validators: matchPasswords('password', 'confirmPassword')})
  }

  ngOnInit(): void {
  }

  onSubmit(){
    this.auth.register(this.registerUser.value)
  }

  // private createForm(model: IUser): FormGroup {
  //   return this.form.group(model, matchPasswords('password', 'confirmPassword'));
  // }

}

function emailValid(){
  return control => {
    var regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/

    return regex.test(control.value) ? null : { invalidEmail: true }
  }
}

function matchPasswords(p, cp){
  return form => {
    if(form.controls[p].value !== form.controls[cp].value){
      return { mismatchedFields: true }
    }
  }
}
