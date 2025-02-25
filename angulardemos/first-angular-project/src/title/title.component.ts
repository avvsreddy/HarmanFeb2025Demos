import { Component } from "@angular/core";


@Component({
    selector:'app-title',
    templateUrl:'title.component.html',
    standalone:true,
    styleUrls:['title.component.css']
})
export class TitleComponent
{
     msg:string='Dynamic data';   
}