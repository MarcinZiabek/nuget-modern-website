declare module server {
	interface package {
		id: string;
		version: string;
		description: string;
		title: string;
		summary: string;
		iconUrl: string;
		projectUrl: string;
		licenseUrl: string;
		totalDownloads: number;
		authors: string[];
		tags: string[];
	}
}
