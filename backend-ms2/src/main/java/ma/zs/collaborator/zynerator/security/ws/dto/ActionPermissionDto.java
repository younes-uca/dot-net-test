package ma.zs.collaborator.zynerator.security.ws.dto;

import com.fasterxml.jackson.annotation.JsonInclude;
import ma.zs.collaborator.zynerator.audit.Log;
import ma.zs.collaborator.zynerator.dto.AuditBaseDto;





@JsonInclude(JsonInclude.Include.NON_NULL)
public class ActionPermissionDto  extends AuditBaseDto {

    private String reference  ;
    private String libelle  ;




    public ActionPermissionDto(){
        super();
    }




    public String getReference(){
        return this.reference;
    }
    public void setReference(String reference){
        this.reference = reference;
    }


    public String getLibelle(){
        return this.libelle;
    }
    public void setLibelle(String libelle){
        this.libelle = libelle;
    }








}
