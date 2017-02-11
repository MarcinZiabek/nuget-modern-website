declare module server {
	interface distribution {
		name: string;
		link: {
			absolutePath: string;
			absoluteUri: string;
			authority: string;
			dnsSafeHost: string;
			fragment: string;
			host: string;
			hostNameType: any;
			idnHost: string;
			isAbsoluteUri: boolean;
			isDefaultPort: boolean;
			isFile: boolean;
			isLoopback: boolean;
			isUnc: boolean;
			localPath: string;
			originalString: string;
			pathAndQuery: string;
			port: number;
			query: string;
			scheme: string;
			segments: string[];
			userEscaped: boolean;
			userInfo: string;
		};
	}
	interface distributionCategory {
		name: string;
		distributions: any[];
	}
}
