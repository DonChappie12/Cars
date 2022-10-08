import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CarDetailsComponent } from './components/car-details/car-details.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { NewCarsComponent } from './components/new-cars/new-cars.component';
import { RegisterComponent } from './components/register/register.component';
import { UsedCarsComponent } from './components/used-cars/used-cars.component';

const routes: Routes = [
  // Todo: When a page is not found show component and after 3s redirect to previous page
  {path: "home", component: HomeComponent},
  {path: "new_cars", component: NewCarsComponent},
  {path: "used_cars", component: UsedCarsComponent},
  // ? Might change url to match naming convention of new/used car details
  {path: "car_details/:id", component: CarDetailsComponent},
  {path: "login", component: LoginComponent},
  {path: "register", component: RegisterComponent},
  {path: "", pathMatch: "full", redirectTo: "home"},
  {path: "**", pathMatch: "full", redirectTo: "home"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
