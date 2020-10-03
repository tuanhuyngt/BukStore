import { CustomersModule } from './customers.module';

describe('DriversModule', () => {
  let customersModule: CustomersModule;

  beforeEach(() => {
    customersModule = new CustomersModule();
  });

  it('should create an instance', () => {
    expect(customersModule).toBeTruthy();
  });
});
