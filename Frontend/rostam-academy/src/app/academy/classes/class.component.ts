import {Component, OnInit} from '@angular/core';
import {Class} from './class.model';
import {ClassService} from './class.service';

@Component({
  selector:'class',
  templateUrl:'./class.component.html',

})

export class ClassComponent implements OnInit
{
  public classes :Array<Class>;

  constructor(private service : ClassService){ }
   ngOnInit(): void
   {
     this.loadClasses();
   }
   loadClasses():void{
     this.service.getAll().subscribe(
       (data:Array<Class>)=>
       {
         this.classes = data;
       })
   }
  public opened = false;
  public dataSaved = false;

  public close() {
    this.opened = false;
  }

  public open() {
    this.opened = true;
  }

  public submit(title:string,classNumber:number)
  {
    debugger;
    this.service.create(new Class(title,classNumber)).subscribe(_class=>this.classes.push(_class));
    this.dataSaved = true;
    this.loadClasses();
    this.close();
  }
}
