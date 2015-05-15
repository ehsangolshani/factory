using System;

namespace Communication
{

	enum RequestType {
		get, // for get new report and stuffs from server.
		/*
		 * { // report
		 * 	{
		 * 		sender_id,
		 * 		sender,
		 * 		recipient_id,
		 * 		recipient_id,
		 * 		send_time,
		 * 		isRead,
		 * 		isMark,
		 * 		description,
		 * 	},
		 * 	// category
		 * 	{
		 * 		title
		 * 	},
		 * 	// attachment
		 * 	{
		 * 		file_name
		 * 	}
		 */
		new_report, // for sending new report
		/*
		 * { 
		 * 		id
		 * }
		 */
		delete_report, // for deleting a report
		/*
		 * { 
		 * 		id
		 * }
		 */
		mark_report, // for marking a report
		/*
		 * { 
		 * 		id
		 * }
		 */
		read_report // for changing report read flag 
	}
}