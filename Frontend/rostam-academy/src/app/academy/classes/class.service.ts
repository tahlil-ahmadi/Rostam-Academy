import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable,of} from 'rxjs';
import {Class} from './class.model';
import {catchError} from 'rxjs/operators';

@Injectable()

export class ClassService {
  private url = "http://localhost:5000/api/classes";

  constructor(private httpClient : HttpClient){ }

  getAll():Observable<Array<Class>>
  {
    return this.httpClient.get<Array<Class>>(this.url);
  }
  create(classToCreate:Class) :Observable<Class> {
    debugger;
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'my-auth-token'
      })
    };
    let _class = classToCreate;
    return this.httpClient.post<Class>(this.url, _class, httpOptions);
  }
  delete(id : number) : Observable<object>
  {
    let deleteUrl = `${this.url}/${id}`;
    return this.httpClient.delete(deleteUrl);
  }
}
