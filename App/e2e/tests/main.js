module.exports = {
	'Test' : function(browser) {
		var home = browser.page.home();
		home.navigate();
		home.isLoaded();
		browser.end();
	}
};