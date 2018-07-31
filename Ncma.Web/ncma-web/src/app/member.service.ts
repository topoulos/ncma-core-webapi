import { Injectable } from '@angular/core';
import { Members } from './mock-members';
import { Member } from './member';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MemberService {

    public getMembers(): Observable<Member[]> {
        return of(Members);
    }

    public getMember(id: number): Observable<Member> {
        return of(Members.find(member => member.id === id));
    }

    constructor() { }
}
