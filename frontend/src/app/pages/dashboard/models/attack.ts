export interface Attack {       //model pre tabulky
    id: number;
    message: string;
    severity: number;
    timestamp: Date;
    src_ip: string;
    dest_ip: string;
    proto: string;
    severityCategory: string;
}