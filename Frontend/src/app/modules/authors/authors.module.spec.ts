import { AuthorsModule } from './authors.module';

describe('DriversModule', () => {
  let authorsModule: AuthorsModule;

  beforeEach(() => {
    authorsModule = new AuthorsModule();
  });

  it('should create an instance', () => {
    expect(authorsModule).toBeTruthy();
  });
});
