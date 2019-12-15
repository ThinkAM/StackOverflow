import { StackOverflowTemplatePage } from './app.po';

describe('StackOverflow App', function() {
  let page: StackOverflowTemplatePage;

  beforeEach(() => {
    page = new StackOverflowTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
