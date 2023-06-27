// Quarter Engineer



$(document).ready(function () {
	$('#plotTransferDiv').hide();
	$('#transButtons').hide();
	$('#bookingId').change(function () {
		if (this.value != '' && this.value != null && this.value != ' ') {
			$('#plotTransferDiv').show();
			$('#transButtons').show();
		}
		else {
			$('#plotTransferDiv').hide();
			$('#transButtons').hide();
		}
	});
});






