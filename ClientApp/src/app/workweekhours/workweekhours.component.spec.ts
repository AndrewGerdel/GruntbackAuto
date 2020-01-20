/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { WorkweekhoursComponent } from './workweekhours.component';

let component: WorkweekhoursComponent;
let fixture: ComponentFixture<WorkweekhoursComponent>;

describe('workweekhours component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ WorkweekhoursComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(WorkweekhoursComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});