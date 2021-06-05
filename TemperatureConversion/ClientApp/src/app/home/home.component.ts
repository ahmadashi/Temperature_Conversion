import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { FormControl, Validators } from '@angular/forms';
import { BehaviorSubject, of, Observable } from 'rxjs';
import { tap, catchError, map } from 'rxjs/operators';
import { TempModel } from '../models/temp-type-model';
import { TempConversionService } from '../temp-conversion.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public createConversionForm: any;  
  public tempTypes: string[] = ['Celsius', 'Fahrenheit', 'Kelvin'];
  public loading$: Observable<boolean>;
  public loaded$: Observable<boolean>;
  public tempModel: TempModel = new TempModel;

  constructor(private formBuilder: FormBuilder,
    private tempConversionService: TempConversionService) {

    

    let inputValueValidators = [
      Validators.required,
      Validators.pattern("^[0-9.]*$"), // to do convert this to directive 
      Validators.maxLength(10)];

    let inputTypeValidators = [
      Validators.required
    ];

    let outputTypeValidators = [
      Validators.required
    ];


    this.createConversionForm = this.formBuilder.group({
      inputType: new FormControl('', inputTypeValidators),
      inputValue: new FormControl('', inputValueValidators),
      outputValue: new FormControl(''),
      outputType: new FormControl('', outputTypeValidators)
      
    });



  }

  ngOnInit() {
    
  }



  onSubmit(customerData) {
    this.tempModel.inputType = customerData.inputType;
    this.tempModel.inputValue = +customerData.inputValue;
    this.tempModel.outputValue = 0;
    this.tempModel.outputType = customerData.outputType;

    this.tempConversionService.convertTemperature(this.tempModel).subscribe(result => {
      this.tempModel = result;
      this.createConversionForm.controls.outputValue.setValue(this.tempModel.outputValue);
    });
    
  }

  onClear() {
    this.createConversionForm.controls.outputValue.setValue(0);
    this.createConversionForm.controls.inputValue.setValue(0);
  }

  public getErrorMessage(control: any) {
    return control.hasError('required') ? 'You must enter a value' :
      control.hasError('maxLength') ? 'not valid value:  max size 10' :        
          control.hasError('pattern') ? 'value must be number' :
          'not valid value:  max size 10';
  }

  public shouldShowErrors(control: any): boolean | any {
    let showError: boolean | any = false;
    if (control && control.errors) {
      showError = (control.dirty || control.touched);
    }
    return showError;
  }

}


  
