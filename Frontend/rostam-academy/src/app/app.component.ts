import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  numbers: Array<string>;
  constructor(){
    this.numbers = new Array<string>();
  }

  addItem(): void{
    let random = Math.floor(Math.random() * 100) + 1 ;
    this.numbers.push(random.toString());
  }
}
