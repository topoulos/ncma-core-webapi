import { Injectable } from '@angular/core';
// import { Members } from './mock-members';
import { Member } from './member';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Config } from './constants/config';
import { MemberListItem } from './memberListItem';

@Injectable({
  providedIn: 'root'
})
export class MemberService {
    private membersUrl = `${Config.baseUrl}/api/members`;  // URL to web api

    public getMembers(): Observable<MemberListItem[]> {
        return this.http.get<MemberListItem[]>(this.membersUrl);
    }

    public getMember(id: number): Observable<Member> {
        return this.http.get<Member>(`${this.membersUrl}/${id}`);
    }

    constructor(
        private http: HttpClient,
    ) { }
}
