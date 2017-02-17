declare module server {
	interface packageVersion {
		commitId: string;
		commitTimeStamp: Date;
		file: string;
		catalogEntry: {
			dataUrl: string;
			id: string;
			version: string;
			description: string;
			title: string;
			summary: string;
			iconUrl: string;
			projectUrl: string;
			licenseUrl: string;
			totalDownloads: number;
			commitTimeStamp: string;
			authors: string[];
			tags: string[];
		};
	}
}
