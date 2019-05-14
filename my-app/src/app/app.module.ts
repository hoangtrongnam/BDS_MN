import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { IndexComponent } from './index/index.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { BlogComponent } from './blog/blog.component';
import { ContactComponent } from './contact/contact.component';
import { ElementsComponent } from './elements/elements.component';
import { ListingsComponent } from './listings/listings.component';
import { SingleBlogComponent } from './single-blog/single-blog.component';
import { SingleListingsComponent } from './single-listings/single-listings.component';
import { DangTinService } from 'src/app/service/DangTin';




import { HttpModule } from '@angular/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';
import { AngularEditorModule } from '@kolkov/angular-editor';


const SERVICES: any = [
  DangTinService
];


@NgModule({
  declarations: [
    AppComponent,
    IndexComponent,
    AboutUsComponent,
    BlogComponent,
    ContactComponent,
    ElementsComponent,
    ListingsComponent,
    SingleBlogComponent,
    SingleListingsComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpModule,
    HttpClientModule,
    AngularEditorModule,

    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [...SERVICES],
  bootstrap: [AppComponent]
})
export class AppModule { }
