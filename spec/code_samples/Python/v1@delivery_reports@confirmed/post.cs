body = ConfirmDeliveryReportsAsReceivedRequest()
body.delivery_report_ids = ['011dcead-6988-4ad6-a1c7-6b6c68ea628d', '3487b3fa-6586-4979-a233-2d1b095c7718', 'ba28e94b-c83d-4759-98e7-ff9c7edb87a1']

result = delivery_reports_controller.confirm_delivery_reports_as_received(body)