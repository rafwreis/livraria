import { Routes , RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LivroComponent } from './pages/livro/livro.component';
import { LivroAddComponent } from './pages/livro-add/livro-add.component';

const routes : Routes = [
    // home
    {
        path: '',
        component : LivroComponent
    },
    // // blog post
    // {
    //     path: ':slug/:id',
    //     component : PostPageComponent
    // },
    // about
    
    {
        path: 'livro',
        component : LivroComponent
    },
    {
        path: 'livro/add',
        component : LivroAddComponent
    },
    {
        path: 'livro/add/:id',
        component : LivroAddComponent
    }
];

export const RoutingModule = RouterModule.forRoot(routes);

