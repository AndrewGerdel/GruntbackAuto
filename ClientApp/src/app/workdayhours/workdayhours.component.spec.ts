/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { WorkdayhoursComponent } from './workdayhours.component';

let component: WorkdayhoursComponent;
let fixture: ComponentFixture<WorkdayhoursComponent>;

describe('workdayhours component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ WorkdayhoursComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(WorkdayhoursComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});