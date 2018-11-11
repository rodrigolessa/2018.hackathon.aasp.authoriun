import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import { RegistroComponent } from './registros/registro.component';
import { AppComponent } from './app.component';
import { AnterioridadeComponent } from './anterioridade/anterioridade.component';

const routes: Routes = [
  {
    path: 'anterioridade',
    component: AnterioridadeComponent,
  },
  {
    path: 'registro',
    component: RegistroComponent,
  },
  {
    path: '**',
    redirectTo: 'anterioridade',
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [],
})
export class AppRoutingModule {}
