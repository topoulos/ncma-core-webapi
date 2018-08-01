import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AlertModule } from 'ngx-bootstrap/alert';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PopoverModule } from 'ngx-bootstrap/popover';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';
import { SortableModule } from 'ngx-bootstrap/sortable';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { TimepickerModule } from 'ngx-bootstrap/timepicker';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { TypeaheadModule } from 'ngx-bootstrap/typeahead';
import { DojoListComponent } from './dojo-list/dojo-list.component';
import { AppRoutingModule } from './/app-routing.module';
import { DojoDetailComponent } from './dojo-detail/dojo-detail.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
// import { MomentModule } from 'ngx-moment';
import { MemberListComponent } from './member-list/member-list.component';
import { MemberDetailComponent } from './member-detail/member-detail.component';
import { CertificateListComponent } from './certificate-list/certificate-list.component';
import { CertificateDetailComponent } from './certificate-detail/certificate-detail.component';
@NgModule({
  declarations: [
    AppComponent,
    DojoListComponent,
    DojoDetailComponent,
    MemberListComponent,
    MemberDetailComponent,
    CertificateListComponent,
    CertificateDetailComponent
  ],
  imports: [
    BrowserModule,
    AlertModule.forRoot(),
    ButtonsModule.forRoot(),
    CarouselModule.forRoot(),
    BsDatepickerModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    PaginationModule.forRoot(),
    PopoverModule.forRoot(),
    ProgressbarModule.forRoot(),
    SortableModule.forRoot(),
    TabsModule.forRoot(),
    TimepickerModule.forRoot(),
    TooltipModule.forRoot(),
    TypeaheadModule.forRoot(),
    AppRoutingModule,
    FormsModule,
    HttpClientModule
    // MomentModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
