<?php include("pageHeader.php"); ?>
<?php
$pageName = "Voucher";
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
                    <div>
                          <a href="voucharPlataformaBase.php" class="btn btn-primary">Uplaod dados Plataforma</a>
                    </div>
                    <div class="col-10 mb-5">
                        <table data-toggle="table" data-search="true" data-show-columns="true">
                            <thead>
                                <tr class="tr-class-1">
                                    <th data-field="codigo" data-valign="middle">Código</th>
                                    <th data-field="codPlataforma" data-valign="middle">Cod Plataforma</th>
                                    <th data-field="produto" data-valign="middle">Produto</th>
                                    <th data-field="tipo">tipo</th>
                                    <th data-field="origem">Origem</th>          
                                    <th data-field="valor">valor</th>             
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="tr-id-1" class="tr-class-1" data-title="Campanha table" data-object='{"key": "value"}'>
                                    <td id="td-id-1" class="td-class-1">23</td>
                                    <td>3232</td>
                                    <td>Americanas</td>
                                    <td>Voucher Digital</td>
                                    <td>Plataforma</td>
                                    <td>50,00</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-2" class="tr-class-2">
                                    <td id="td-id-2" class="td-class-1">45</td>
                                    <td>2346</td>
                                    <td>Americanas</td>
                                    <td>Voucher Digital</td>
                                    <td>Plataforma</td>
                                    <td>150,00</td>                                  
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-3" class="tr-class-3">
                                    <td id="td-id-3" class="td-class-3">6683</td>
                                    <td></td>
                                    <td>XPTO</td>
                                    <td>Voucher Digital</td>
                                    <td>Avulso</td>
                                    <td></td>                          
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-flag-checkered  text-warning" title="Finalizar Campanha"></i></a>
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
                                        <i class="fa fa-fw fa-credit-card"></i>&nbsp; <?php echo $pageName ?>
                                    </h4>
                                </div>
                            </div>
                            <form>
                                <div class="card-body bg-light text-dark">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label for="nomeCampanha">Nome</label>
                                            <input type="text" class="form-control" name="nomeCampanha" id="nomeCampanha" placeholder="Digite o nome da Campanha" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="row">
                                        <div class="col-md-6">
                                            <label for="tipoCampanha">Tipo</label>
                                            <select class="form-control" name="tipoCampanha" id="tipoCampanha">
                                                <option value="opcao 1" selected>Digital</option>
                                                <option value="opcao 2" selected>Fisico</option>
                                                <option value="" selected>Selecione ...</option>
                                            </select>
                                        </div>                                  
                                        <div class="col-md-6">
                                            <label for="origemCampanha">Origem</label>
                                            <select class="form-control" name="origemCampanha" id="origemCampanha">
                                                <option value="opcao 1" selected>Pataforma</option>
                                                <option value="opcao 2" selected>Avulso</option>
                                                <option value="" selected>Selecione ...</option>
                                            </select>
                                        </div>
                                    </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="codigoPlataforma">Cod Plataforma</label>
                                            <input type="text" class="form-control" name="codigoPlataforma" id="codigoPlataforma" />
                                        </div>
                                        <div class="col-md-6">
                                            <label for="valor">Valor</label>
                                            <input type="text" class="form-control" name="valor" id="valor" placeholder="Digite valor" />
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
