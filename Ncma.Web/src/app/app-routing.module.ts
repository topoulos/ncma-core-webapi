import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DojoListComponent } from './dojo-list/dojo-list.component';
import { DojoDetailComponent } from './dojo-detail/dojo-detail.component';
import { MemberListComponent } from './member-list/member-list.component';
import { MemberDetailComponent } from './member-detail/member-detail.component';
import { CertificateListComponent } from './certificate-list/certificate-list.component';
import { CertificateDetailComponent } from './certificate-detail/certificate-detail.component';

const routes: Routes = [
    { path: 'dojos', component: DojoListComponent },
    { path: 'dojos/:id', component: DojoDetailComponent },
    { path: 'members', component: MemberListComponent },
    { path: 'members/:id', component: MemberDetailComponent },
    { path: 'certificates', component: CertificateListComponent },
    { path: 'certificates/:id', component: CertificateDetailComponent }
  ];

@NgModule({
  exports: [ RouterModule ],
  imports: [RouterModule.forRoot(routes)]
})
export class AppRoutingModule {}
