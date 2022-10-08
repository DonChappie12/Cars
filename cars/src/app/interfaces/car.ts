import { IEngine } from './engine';

export interface ICar {
  make: string,
  model: string,
  year: number,
  style: string,
  wear: string,
  mileage: string,
  color: string,
  mpg: number,
  warranty?: string,
  drivetrain: string,
  description: string,
  engine:{
    [key: string]: IEngine
  }
}
