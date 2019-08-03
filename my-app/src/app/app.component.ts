import { Component } from '@angular/core';
import { DangTinService } from 'src/app/service/DangTin';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title;


  constructor (
    private dangtin: DangTinService
  ) {}


  ngOnInit() {
    
        this.dangtin.getAll().subscribe(data2 => {
          this.title = data2.ID;
          console.log(this.title);
        });
    
      }
}
