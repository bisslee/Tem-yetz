<?php include("pageHeader.php"); ?>
<?php
$pageName = "Notas Fiscais";
?>
<?php include("breadcrumb.php"); ?>


            <div class="row">
                <div class="col-12 mb-5">
                    <h1><?php echo $pageName ?></h1>  
                    <div>                       
                        <!--Indicadores-->
                        <!--Info-->
                        <a class="mr-lg-2" id="info" href="#">
                            <i class="fa fa-fw fa-info-circle text-dark"></i>
                            <span class="d-lg-none">Total</span>
                            <span class="badge badge-pill badge-dark">1235</span>
                        </a>
                        <a class="mr-lg-2" id="ok" href="#">
                            <i class="fa fa-fw fa-check-circle text-success"></i>
                            <span class="d-lg-none">OK</span>
                            <span class="badge badge-pill badge-success">1235</span>
                        </a>
                        <a class="mr-lg-2" id="Error" href="#">
                            <i class="fa fa-fw fa-exclamation-circle text-danger"></i>
                            <span class="d-lg-none">Com problemas</span>
                            <span class="badge badge-pill badge-danger">1235</span>
                        </a>     
                        <a class="mr-lg-5" id="New" href="#">
                            <i class="fa fa-fw fa-plus-circle text-primary"></i>
                            <span class="text-dark">Novo</span>
                        </a>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <!--Table-->
                    <div class="col-10 mb-5">
                        <table data-toggle="table" data-search="true" data-show-columns="true">
                            <thead>
                                <tr class="tr-class-1">
                                    <th data-field="numeroNota" data-valign="middle">No. Nota</th>
                                    <th data-field="pagador" data-valign="middle">Pagador</th>
                                    <th data-field="valorNota">Valor</th>
                                    <th data-field="dataNota">Data </th>
                                    <th data-field="statusNota">Status</th>
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="tr-id-1" class="tr-class-1" data-title="Nota Fiscal table" data-object='{"key": "value"}'>
                                    <td id="td-id-1" class="td-class-1">23423</td>
                                    <td>Itaú</td>
                                    <td>200000,00</td>
                                    <td>20/05/2020</td>
                                    <td>Paga</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>                                      
                                    </td>
                                </tr>
                                <tr id="tr-id-2" class="tr-class-2">
                                    <td id="td-id-2" class="td-class-2">3453</td>
                                    <td>Sulamerica</td>
                                    <td>820000,00</td>
                                    <td>20/08/2020</td>
                                    <td>Emitida</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>
                                <tr id="tr-id-3" class="tr-class-3">
                                    <td id="td-id-3" class="td-class-3">996776</td>
                                    <td>Itaú</td>
                                    <td>450000,00</td>
                                    <td>20/08/2020</td>
                                    <td>Emitida</td>
                                    <td>
                                       <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>
                                <tr id="tr-id-4" class="tr-class-4">
                                    <td id="td-id-4" class="td-class-4">33456</td>
                                    <td>Vivo</td>
                                    <td>1450000,00</td>
                                    <td>20/08/2020</td>
                                    <td>Emitida</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>
                                <tr id="tr-id-5" class="tr-class-5">
                                    <td id="td-id-5" class="td-class-5">23232</td>
                                    <td>XDS</td>
                                    <td>1450000,00</td>
                                    <td>20/08/2020</td>
                                    <td>Paga</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                    <!--Form-->
                    <div class="col-10 mb-5">
                        <div class="card text-white bg-dark o-hidden h-100">
                            <div class="card-header">
                                <div class="mr-5">
                                    <h4>
                                        <i class="fa fa-fw fa-money"></i>&nbsp; <?php echo $pageName ?>
                                    </h4>
                                </div>
                            </div>
                            <form>
                                <div class="card-body bg-light text-dark">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="nomeCampanha">Campanha</label>
                                            <select class="form-control" name="nomeCampanha" id="nomeCampanha">
                                                <option value="opcao 1" selected>opcao 1</option>
                                                <option value="opcao 2" selected>opcao 2</option>
                                                <option value="opcao 3" selected>opcao 3</option>
                                                <option value="" selected>Selecione ...</option>
                                            </select>
                                        </div>                                  
                                        <div class="col-md-6">
                                            <label for="cliente">Cliente</label>
                                            <input type="text" disabled class="form-control" name="cliente" id="cliente" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="nomePagador">Pagador</label>                                            
                                            <select class="form-control" name="nomePagador" id="nomePagador">
                                                <option value="opcao 1" selected>opcao 1</option>
                                                <option value="opcao 2" selected>opcao 2</option>
                                                <option value="opcao 3" selected>opcao 3</option>
                                                <option value="" selected>Selecione ...</option>
                                            </select>
                                        </div>                                  
                                        <div class="col-md-6">
                                            <label for="cnpj">CNPJ</label>
                                            <input type="text" disabled class="form-control" name="cliente" id="cliente" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="contatoPagador">Contato</label>                                            
                                            <input type="text" disabled class="form-control" name="contatoPagador" id="contatoPagador" />
                                        </div>                                  
                                        <div class="col-md-6">
                                            <label for="email">E-mail</label>
                                            <input type="text" disabled class="form-control" name="email" id="email" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="telefonePagador">TelefonePagador</label>                                            
                                            <input type="text" disabled class="form-control" name="telefonePagador" id="telefonePagador" />
                                        </div>                                  
                                        <div class="col-md-6">
                                            <label for="celularContato">Celular</label>
                                            <input type="text" disabled class="form-control" name="celularContato" id="celularContato" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <label for="numeroNota">Numero</label>
                                            <input type="number" class="form-control" name="numeroNota" id="numeroNota" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="valorNota">Valor</label>
                                            <input type="number" class="form-control" name="valorNota" id="valorNota" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="dataEmissao">Data Emissão</label>
                                            <input type="number" class="form-control" name="dataEmissao" id="dataEmissao"/>
                                        </div>
                                        <div class="col-md-3">
                                            <label for="statusNota">Status</label>
                                            <select  class="form-control" name="statusNota" id="statusNota">
                                                <option value="emitida" selected>Emitida</option>
                                                <option value="paga" selected>Paga</option>
                                                <option value="cancelada" selected>Cancelada</option>
                                                <option value="pendente" selected>Pendente</option>
                                            </select>
                                        </div>                                       
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label for="observacao">Observação</label>
                                            <textarea class="form-control" name="observacao" id="observacao"></textarea>
                                        </div>                                        
                                    </div>
                                </div>
                                <div class="card-footer bg-dark pull-right">
                                    <button class="btn btn-success" type="submit">Salvar</button>
                                    <button class="btn btn-danger" type="reset">Cancelar</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>    

            </div>
        
<?php include("pageFooter.php"); ?>
