import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DojoListComponent } from './dojo-list/dojo-list.component';
import { DojoDetailComponent } from './dojo-detail/dojo-detail.component';

const routes: Routes = [
    { path: 'dojos', component: DojoListComponent },
    { path: 'dojos/:id', component: DojoDetailComponent }
  ];

@NgModule({
  exports: [ RouterModule ],
  imports: [RouterModule.forRoot(routes)]
})
export class AppRoutingModule {}
