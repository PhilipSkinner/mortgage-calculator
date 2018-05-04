module.exports = {
	url : 'http://localhost:5000',
	elements : {
		body : 'body'
	},
	commands : [
		{
			isLoaded : function() {
				this.expect.element('@body').to.be.present;
				this.expect.element('@body').to.be.visible;
			}
		}
	]
};